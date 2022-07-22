#실습2-1
CREATE TABLE `User2` (
`uid` VARCHAR(10) PRIMARY KEY,
`name` VARCHAR(10),
`hp` CHAR(13),
`age` INT
);

#실습2-2
CREATE TABLE `User3`(
`uid` VARCHAR(10) PRIMARY KEY,
`name` VARCHAR(10),
`hp` CHAR(13) UNIQUE,
`age` INT
);

#실습2-3
CREATE TABLE `Parent`(
`pid` VARCHAR(10) PRIMARY KEY,
`name` VARCHAR(10),
`hp` CHAR(13) UNIQUE
);

CREATE TABLE `Child`(
`cid` VARCHAR(10) PRIMARY KEY,
`name` VARCHAR(10),
`hp` CHAR(13) UNIQUE,
`pid` VARCHAR(10),
FOREIGN KEY(`cid`) REFERENCES `parent` (`pid`)
);

#실습 2-4
CREATE TABLE `User4`(
`seq` INT AUTO_INCREMENT PRIMARY KEY,
`name` VARCHAR(10),
`gender` TINYINT,
`age` INT,
`addr` VARCHAR(255)
);

#실습 2-5
CREATE TABLE `User5`(
`seq` INT AUTO_INCREMENT PRIMARY KEY,
`name` VARCHAR(10) NOT NULL,
`gender` TINYINT,
`age` INT DEFAULT 1,
`addr` VARCHAR(255)
);

#실습 2-6
CREATE TABLE `User6` LIKE `User5`;

#실습 2-7
INSERT INTO `User6` SELECT * FROM `User5`;
INSERT INTO `User6` (`name`, `gender`,`age`,`addr)
				SELECT `name`, `gender`, `age`, `addr` FROM `User5`;
				
