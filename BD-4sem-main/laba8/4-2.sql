use UNIVER;
SELECT STUDENT.NAME, DATEDIFF(year, STUDENT.BDAY, GETDATE()) [Возраст] FROM STUDENT
WHERE MONTH(STUDENT.BDAY) = MONTH(DATEADD(m, 1, GETDATE()));