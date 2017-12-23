create table if not exists migrations (
	pk_migration_id integer,
	fk_version_id integer,
	migration_number integer,
	release_date date,
	
	PRIMARY KEY ('pk_migration_id'),
	FOREIGN KEY ('fk_version_id') REFERENCES versions('pk_version_id')
)