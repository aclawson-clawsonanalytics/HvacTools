create table if not exists 'versions' (
	pk_version_id integer,
	start_date date,
	close_date date,
	
	PRIMARY KEY ('pk_version_id')
)