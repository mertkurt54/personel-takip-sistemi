create trigger delete_pz on POZISYON after delete as
begin
declare @id int
select @id=ID from deleted
delete from PERSONEL where PozisyonID=@id
end
