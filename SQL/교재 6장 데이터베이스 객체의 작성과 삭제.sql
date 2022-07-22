#날짜 : 2022/07/21
#이름 : 조경은
# 

#실습 6-1
CREATE DATABASE `SaleDB`;
CREATE USER 'manager'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON SaleDB.* TO 'manager'@'%';
FLUSH PRIVILEGES;


#실습 6-2
CREATE TABLE `고객 테이블(Customer)`
	`컬럼명(한글)` VARCHAR(10),
	`영문명` VARCHAR(20),
	`데이터유형` CHAR(10),
	`길이` VARCHAR(40)
	`NULL허용`VARCHAR(10),
	`기본값`VARCHAR(10)
	);
	DROP TABLE SaleDB

	INSERT INTO SaleDB VALUES('아이디(PK)', 'uid', '문자열', '10', 'X', '없음');
	INSERT INTO SaleDB VALUES ('이름', 'name', '문자열', '10', 'X', '없음');
	INSERT INTO SaleDB VALUES ('휴대폰(UK)', 'hp', '문자열', '13', 'X', '없음');
	INSERT INTO SaleDB VALUES ('직급', 'pos', '문자열', '10', 'X', '사원');
	INSERT INTO SaleDB VALUES ('이름', 'dep', '숫자', '정수', 'O', 'NULL');
	INSERT INTO SaleDB VALUES ('이름', 'rdate', '날짜시간', '날짜시간', 'X', '없음');


#실습 6-3
CREATE TABLE sample62 (
	`custled` VARCHAR(10),
	`name` VARCHAR(20),
	`hp` CHAR(10),
	`addr` VARCHAR(40),
   `rdate` DATE(10)
	);
	DROP TABLE sample62

	DROP TABLE sample62
	
	INSERT INTO sample62 VALUES ('heoj', '허준', '1976-10-18', 2022-01-07);
	INSERT INTO sample62 (`no`,  `name`, `address`)
					 VALUES ('2', '김재진', '대구광역시 동구')

	INSERT INTO `sample21` SET `no` = '3', `name` = '홍길동', `address` = '서울특별시 마포구');

#실습 6-4
#실습 6-5
#실습 6-6
#실습 6-7
#실습 6-8
#실습 6-9
#실습 6-10

#실습 6-11
#실습 6-12
#실습 6-13
#실습 6-14
#실습 6-15
#실습 6-16
#실습 6-17
#실습 6-18
#실습 6-19
#실습 6-20

#실습 6-21
#실습 6-22
#실습 6-23
#실습 6-24
#실습 6-25
#실습 6-26
#실습 6-27
#실습 6-28
#실습 6-29
#실습 6-30


CREATE DATABASE `SaleDB`;
CREATE USER 'manager'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON `SaleDB`.* TO 'manager'@'%';
FLUSH PRIVILEGES;

CREATE TABLE `Member` (
	`uid`		VARCHAR(10) PRIMARY KEY,
	`name`	VARCHAR(10) NOT NULL,
	`hp`		CHAR(13) UNIQUE NOT NULL,
	`pos`		VARCHAR(10) NOT NULL,
	`dep`		TINYINT,
	`rdate`	DATETIME  NOT NULL
);

CREATE TABLE `Department` (
	`depNo`	TINYINT PRIMARY KEY,
	`name`	VARCHAR(10) NOT NULL,
	`tel`		CHAR(12) NOT NULL
);
CREATE TABLE `Sales` (
	`seq`		INT AUTO_INCREMENT PRIMARY KEY,
	`uid`		VARCHAR(10) NOT NULL,
	`year`	YEAR NOT NULL,
	`month`	TINYINT NOT NULL,
	`sale`	INT NOT NULL
);

INSERT INTO `Member` VALUES ('a101', '박혁거세', '010-1234-1001', '부장', 101, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a102', '김유신',   '010-1234-1002', '차장', 101, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a103', '김춘추',   '010-1234-1003', '사원', 101, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a104', '장보고',   '010-1234-1004', '대리', 102, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a105', '강감찬',   '010-1234-1005', '과장', 102, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a106', '이성계',   '010-1234-1006', '차장', 103, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a107', '정철',     '010-1234-1007', '차장', 103, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a108', '이순신',   '010-1234-1008', '부장', 104, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a109', '허균',     '010-1234-1009', '부장', 104, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a110', '정약용',   '010-1234-1010', '사원', 105, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a111', '박지원',   '010-1234-1011', '사원', 105, '2020-11-19 11:39:48');
INSERT INTO `Department` VALUES (101, '영업1부', '051-512-1001');
INSERT INTO `Department` VALUES (102, '영업2부', '051-512-1002');
INSERT INTO `Department` VALUES (103, '영업3부', '051-512-1003');
INSERT INTO `Department` VALUES (104, '영업4부', '051-512-1004');
INSERT INTO `Department` VALUES (105, '영업5부', '051-512-1005');
INSERT INTO `Department` VALUES (106, '영업지원부', '051-512-1006');
INSERT INTO `Department` VALUES (107, '인사부', '051-512-1007');
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a101', 2018, 1,  98100);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2018, 1, 136000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2018, 1,  80100);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2018, 1,  78000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2018, 1,  93000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a101', 2018, 2,  23500);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2018, 2, 126000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2018, 2,  18500);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2018, 2,  19000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a106', 2018, 2,  53000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a101', 2019, 1,  24000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2019, 1, 109000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2019, 1, 101000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2019, 1,  53500);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a107', 2019, 1,  24000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2019, 2, 160000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2019, 2, 101000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2019, 2,  43000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2019, 2,  24000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a106', 2019, 2, 109000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2020, 1, 201000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2020, 1,  63000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2020, 1,  74000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a106', 2020, 1, 122000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a107', 2020, 1, 111000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2020, 2, 120000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2020, 2,  93000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2020, 2,  84000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2020, 2, 180000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a108', 2020, 2,  76000);
