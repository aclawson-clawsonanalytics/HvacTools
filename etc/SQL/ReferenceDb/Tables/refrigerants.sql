CREATE TABLE IF NOT EXISTS 'refrigerants' (
	'pk_refrigerant_id' INTEGER NOT NULL,
	'fk_refrigerant_type_id' INTEGER NOT NULL,
	'chemical_name' TEXT,
	'ashrae_code' TEXT,
	
	PRIMARY KEY ('pk_refrigerant_id'),
	FOREIGN KEY ('fk_refrigerant_type_id') REFERENCES refrigerant_types('pk_refrigerant_type_id')
)