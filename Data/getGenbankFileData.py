import re
#filename=input("Enter the genome file name")
#path=path='C:\\Users\\Matt\\Desktop\\Marthaler\\genomes\\'
path=''
filename='dataInput.txt'
with open(path+filename,'r') as f:
	rawData=f.read()

def buildDataDictionary(rawData):
	data={}
	data['id']=re.search(r'LOCUS + [A-Z]+.\d+',rawData).group(0)[12:]
	#get numbe rof bas pairs
	data['base_pairs']=re.search(r'\d+ bp', rawData).group(0)[0:-3]
	#get protien starts
	
	m=re.findall(r'CDS\s+.[0-9]+\.\.[0-9]+',rawData)
	protienPositions=[]
	for protien in m:
		i=re.findall(r'[0-9]+',protien)
		protienPositions.append(i[0]+'-'+i[1])
	data['protien_positions']=protienPositions
	
	#get publishing data
	substring=rawData
	titles=[]
	while(substring.find('TITLE')!=-1):
		substring=substring[substring.index('TITLE')+5:]
		titles.append(substring[:substring.index('JOURNAL')].replace('\n', ' ').lstrip())
	data['titles']=titles
	
	substring=rawData
	journals=[]
	while(substring.find('JOURNAL')!=-1):
		substring=substring[substring.index('JOURNAL')+7:]
		if (substring.find('JOURNAL')==-1):
			journals.append(substring[:substring.index('FEATURES')].replace('\n',' ').lstrip())
		else:
			journals.append(substring[:substring.index('JOURNAL')].replace('\n',' ').lstrip())
	data['journals']=journals
	
	#sugguest researchers
	data['authors']=re.search(r'AUTHORS .+',rawData[rawData.index('AUTHORS'):rawData.index('TITLE')].replace('\n', ' ')).group(0)[8:]
	#isolate genome
	startIndex=rawData.index('ORIGIN')+6
	genome=''
	for c in rawData[startIndex:]:
		if c.isalpha():
			genome+=c
	data['genome']=genome
	#get true start Codons
	allATGPositions=[]
	for i in range(len(genome)):
		if genome[i:i+3]=='atg':
			allATGPositions.append(i+1)
	data['all_atg_positions']=allATGPositions
	#get all true start codon positions
	selectedATGPositions=[]
	for pos in protienPositions:
		selectedATGPositions.append(int(pos.split('-')[0]))
	data['true_start_positions']=selectedATGPositions
	#get all false start codon positions
	unselectedATGPositions=[]
	for pos in allATGPositions:
		if pos not in selectedATGPositions:
			unselectedATGPositions.append(pos)
	data['false_start_positions']=unselectedATGPositions
	return data

dict=buildDataDictionary(rawData)
f=open('dataOUT.txt','w')
f.write("('" + dict['id'] + "'," + dict['base_pairs'] + ", "  + "SPECIES, '"+ dict['genome'] + "')\n")
f.write("\n")
f.write("('" + dict['id'] + "', '1a', 0, , ),\n")
f.write("('" + dict['id'] + "', '1b', 1, , ),")
for i in dict['protien_positions']:
	split=i.split('-')
	f.write("\n('" + dict['id'] + "', 'ORF', " + "PID, " + split[0] + ", " + split[1] + "),") 
#sugguested authors
f.write('\n')
f.write('\nSUGGUESTED RESEARCHERS/AUTHORS::: ' + dict['authors']);
#sugguested publications and titles
f.write('\n\nSUGGUESTED PUBLICATIONS AND JOURNALS:\n')
for i in range(len(dict['titles'])):
	f.write('Title: ' + dict['titles'][i] + '\n')
	f.write('Publisher: ' + dict['journals'][i] + '\n') 