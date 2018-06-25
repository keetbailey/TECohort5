-- Write queries to return the following:
-- Make the following changes in the "world" database.

-- 1. Add Superman's hometown, Smallville, Kansas to the city table. The 
-- countrycode is 'USA', and population of 45001. (Yes, I looked it up on 
-- Wikipedia.)
SELECT * FROM city WHERE district = 'Kansas';

INSERT INTO city(id, name, countrycode, district, population)
VALUES (5000, 'Smallville', 'USA', 'Kansas', 45001);

-- 2. Add Kryptonese to the countrylanguage table. Kryptonese is spoken by 0.0001
-- percentage of the 'USA' population.
SELECT * FROM countrylanguage WHERE language is not null
ORDER BY countrycode DESC;

INSERT INTO countrylanguage(countrycode, language, isofficial, percentage)
VALUES('USA', 'Kryptonese', 0, 0.0001);

-- 3. After heated debate, "Kryptonese" was renamed to "Krypto-babble", change 
-- the appropriate record accordingly.
SELECT * FROM countrylanguage WHERE language is not null
ORDER BY countrycode DESC;


UPDATE countrylanguage
SET language = 'Krypto-babble'
WHERE language = 'Kryptonese';

-- 4. Set the US captial to Smallville, Kansas in the country table.
SELECT * FROM country WHERE code = 'USA'

UPDATE country
SET capital = 5000
WHERE code = 'USA';

-- 5. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)
SELECT * FROM city WHERE district = 'Kansas'
DELETE FROM city
WHERE id = 5000;

Succeeded

-- 6. Return the US captial to Washington.
SELECT * FROM country WHERE code = 'USA'


UPDATE country
SET capital = 3813
WHERE code = 'USA';

-- 7. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)

DELETE FROM city
WHERE id = 5000;

-- Did not succeed due to previous deletion - no errors, just 0 rows affected 

-- 8. Reverse the "is the official language" setting for all languages where the
-- country's year of independence is within the range of 1800 and 1972 
-- (exclusive). 
-- (590 rows affected)

SELECT * FROM countrylanguage WHERE countrycode IN (SELECT code FROM country WHERE indepyear BETWEEN 1801 AND 1971);

UPDATE countrylanguage
SET isofficial = 0 
WHERE countrycode IN 
(
	SELECT code 
	FROM country
	WHERE indepyear BETWEEN 1801 AND 1971
);

--- Need to revisit - On this one, I unfortunately changed all values of isofficial to 0, rather than doing the inverse.  - KSB

-- 9. Convert population so it is expressed in 1,000s for all cities. (Round to
-- the nearest integer value greater than 0.)
-- (4068 rows affected)
SELECT * FROM city WHERE countrycode = 'USA';
UPDATE city
SET population = ceiling(population / 1000)
WHERE population > 0;

-- 10. Assuming a country's surfacearea is expressed in miles, convert it to 
-- meters for all countries where French is spoken by more than 20% of the 
-- population.
-- (7 rows affected)
SELECT name, surfacearea FROM country WHERE code IN (SELECT countrycode FROM countrylanguage WHERE language = 'French' AND percentage >= .20)

UPDATE country
SET surfacearea = surfacearea * 1609.34 --1609 meters in mile 
WHERE code IN 
(
	SELECT countrycode
	FROM countrylanguage
	WHERE language = 'French' AND percentage >= .20
);