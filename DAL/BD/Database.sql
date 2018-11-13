CREATE database if not exists projetIA character set utf8 collate utf8_unicode_ci;
use projetIA;

grant all privileges on projetIA.* to 'projetIA_user'@'localhost' identified by 'secret';