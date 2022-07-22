#날짜 : 2022/07/18
#이름 : 조경은
#내용 : 교재 2장 테이블에서 데이터 검색
CREATE DATABASE `sample21`;
DROP DATABASE `sample21`;

CREATE TABLE `sample21` (
	`no` VARCHAR(10),
	`name` VARCHAR(20),
	`birthday` CHAR(10),
	`adderess` VARCHAR(40)
	);
	DROP TABLE `sample21`
	
	
	INSERT INTO `sample21` VALUES ('1', '박준용', '1976-10-18', '대구광역시 수성구');
	INSERT INTO `sample21` (`no`,  `name`, `address`)
					 VALUES ('2', '김재진', '대구광역시 동구')

	INSERT INTO `sample21` SET `no` = '3', `name` = '홍길동', `address` = '서울특별시 마포구');
	
	
	
-----------------------------
#4강 Hello World 실행하기
-----------------------------
#p52
SELECT * FROM sample21;



-----------------------------
#5강 테이블 구조 참조하기
-----------------------------
#p62
mysql>DESC `sample21`;

-----------------------------
#6강 검색 조건 저장하기 
-----------------------------
#p66
SELECT * FROM `sample21`;
SELECT NO, NAME FROM `sample21`;

#p68
SELECT * FROM `sample21`;
SELECT * FROM `sample21` WHERE NO = 2;


#p70
SELECT * FROM `sample21`; 
SELECT * FROM `sample21` WHERE NO<>2;

#p71
SELECT * FROM `sample21`;
SELECT * FROM `sample21` WHERE NAME = '박준용';
#p75
SELECT * FROM `sample21`;
SELECT * FROM `sample21` WHERE birthday = NULL;
#p76
SELECT * FROM `sample21`;
SELECT * FROM `sample21` WHERE birthday IS NULL;



-----------------------------
#7강 조건 조합하기
-----------------------------
CREATE TABLE 



#p76
#p77
#p78
#p80
#p82

-----------------------------
#8강 패턴 매칭에 의한 검색
-----------------------------
#p84
#p85
#p86
#p88


