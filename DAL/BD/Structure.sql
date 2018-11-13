DROP table if exists question;

CREATE table question (
    question_id integer not null primary key auto_increment,
	question_enonce varchar(1000) not null,
    question_trueAnswer varchar(1000) not null,
	question_falseAnswer1 varchar(1000) not null,
	question_falseAnswer2 varchar(1000) not null,
	question_falseAnswer3 varchar(1000) not null,
	question_difficulte varchar(10) not null,
	question_nbPoints integer(2) not null,
	question_image boolean null
	-- Mettre le chemin pour trouver une image dans la BDD  !!!!!
	
);