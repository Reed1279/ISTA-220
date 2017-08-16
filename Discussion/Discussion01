### MSSA Cohort 3
### Course: ISTA-420
### Lesson Plan: 01
## Name: Tyler Reed
## Date: 16 August, 2017

1. Give an informal definition of database as used in the expression "relational database management
system."
    Software
1. Give an informal definition of database as used in the expression “Human Resources database."
    Data in the database
1. Give an informal definition of entity integrity.
    Makingeach row unique
1. Give an informal definition of referential integrity.
    Attributes with foreign keys contain only data that appears in the referencing key's attributes
1. What is a relation as defined in the textbook? A one word answer to this question is sufficient.
    A set 
1. Is this table in first normal form? Why or why not? If it is not, how would you change it?
    ```sql
    create table faculty (
      facID int primary key,
      facName text,
      facCreds text);
    ```
    | facID | facName          | facCreds          |
    |-------|------------------|-------------------|
    | 1     | Alan Alda        | BA, MA            |
    | 2     | Bridgette Bardot | BS, MS, PhD       |
    | 3     | Casey Cason      | AA, BBA, MBA, DEd |
    No/each row is identified by a primary key/firstName, lastName, and the credentials should be referenced using foreign keys that point to a separate table 
1. Is this table in second normal form? Why or why not? If it is not, how would you change it?
    ```sql
    create table pets (
      ownerID int primary key,
      petID int primary key,
      ownerFirstName text,
      ownerLastName text,
      petName text,
      petType text);
    ```
    | ownerID | petID | ownerFirstName | ownerLastName | petName  | petType         |
    |---------|-------|----------------|---------------|----------|-----------------|
    | 1       | 1     | Dom            | Delouise      | Rex      | German Shepherd |
    | 1       | 2     | Dom            | Delouse       | Lacy     | Border Collie   |
    | 2       | 3     | Emilio         | Estevez       | Midnight | Persian Cat     |
    No/the non-key attributes do not depend on the entire primary key
1. Is this table in third normal form? Why or why not? If it is not, how would you change it?
    ```sql
    create table friends (
      friendID int primary key,
      friendName text,
      friendStreet text,
      friendCity text,
      friendState text,
      friendZip text);
    ```
    | ID | FirstName | LastName  | Street               | City     | State | Zip   |
    |----|-----------|-----------|----------------------|----------|-------|-------|
    | 1  | Fred      | Flinstone | 123 Rock Quarry Rd   | Bedrock  | GA    | 31905 |
    | 2  | Greta     | Garbo     | 456 Starlit Ave      | Paris    | FL    | 30019 |
    | 3  | Harry     | Houdini   | 789 Hidden Glen Lane | Alcatraz | CA    | 00000 |
    No/the address information is dependent on itself and should be moved to a separate table/A new table should be created with ZIP as the primary key with city and state attributes
1. What is an OLTP database? What operations is it optimized for?
    A database used for data entry and not reporting/insert, update, and delete data
1. What is a star schema? What operations is it optimized for?
    Designed based on a fact table which contains the elements of interest/it is optimized for data analysis