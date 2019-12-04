if not exists (select top(1) 0 from Roles)
begin
insert into [dbo].[Roles] ([Name],[CreateUserId])
values (N'Administrator',1),(N'User',1)
end

if not exists (select top(1) 0 from Genders)
begin
insert into [dbo].[Genders] ([Name],[CreateUserId])
values (N'Kisi',1),(N'Qadin',1)
end

if not exists (select top(1) 0 from Users)
begin
insert into [dbo].[Users] ([Email],[Password],[Name],[Surname],[GenderId],[RoleId],[CreateDate],[CreateUserId])
values (N'admin@mail.ru','1234','Admin','Adminli',1,1,GETDATE(),1),
       (N'user@mail.ru','1234','User','Userli',1,2,GETDATE(),1)

end

if not exists (select top(1) 0 from Categories)
begin
insert into [dbo].[Categories] ([Name],[CreateUserId])
values (N'Mobil telefonlar',1), (N'Foto Texnika',1),(N'Meiset Texnikasi',1),(N'Kicik Meiset Texnikasi',1),(N'Tv,Audio',1),(N'Kompyuter ve Ofis avadanligi',1)
end

