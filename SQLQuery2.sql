create trigger delete_dp on DEPARTMAN after delete as
begin
declare @id int
select @id=ID from deleted
delete from POZISYON where DepartmanID=@id



end