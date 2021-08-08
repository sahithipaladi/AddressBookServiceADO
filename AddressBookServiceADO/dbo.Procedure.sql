CREATE PROCEDURE dbo.AddContact
(
	@FirstName varchar(100),
	@LastName varchar(100),
	@Address varchar(250),
	@City varchar(100),
	@State varchar(100),
	@Zip BigInt,
	@PhoneNumber BigInt,
	@Email varchar(200),
	@AddressBookName varchar(50),
	@RelationType varchar(50)
	)
AS
BEGIN
	Insert into AddressBookServiceTable values(@FirstName,@LastName,@Address,@City,@State,@Zip,@PhoneNumber,@Email,@AddressBookName,@RelationType)
	Insert into AddressBook(AddressBookName) values(@AddressBookName)
	
	Insert into ContactType(ContactTypeName) values(@RelationType)
END