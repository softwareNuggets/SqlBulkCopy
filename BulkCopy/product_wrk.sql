--truncate all the data from work table
truncate table product_wrk

--remove product_wrk from the database
--this is permanent ... be careful
drop table Product_wrk

-- create table
create table Product_wrk
(
	productId int not null primary key,
	product_short_desc varchar(64) not null,
	product_upc varchar(20) not null
)