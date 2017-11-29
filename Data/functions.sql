DELIMITER //

CREATE FUNCTION sanitize(chode varchar(50))
RETURNS varchar(50)
BEGIN
	RETURN upper(chode);
END//

--

CREATE FUNCTION protein_trg_fn()
RETURNS trigger
BEGIN
	execute sanitize(new.pName);
END//

--

CREATE TRIGGER proteins_trg BEFORE INSERT OR UPDATE ON Proteins
       FOR EACH ROW EXECUTE PROCEDURE sanitize(pName);







