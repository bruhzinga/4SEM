use UNIVER;
SELECT	GROUPS.FACULTY [Факультет],
		GROUPS.PROFESSION [Специальность],
		PROGRESS.SUBJECT [Предмет],
		round(avg(cast(PROGRESS.NOTE AS float(4))), 2) [Средний балл]
	FROM GROUPS, STUDENT, PROFESSION, PROGRESS
	WHERE GROUPS.FACULTY in ('ТОВ')
	GROUP BY GROUPS.FACULTY,
			 GROUPS.PROFESSION,
			 PROGRESS.SUBJECT
UNION ALL
SELECT	GROUPS.FACULTY [Факультет],
		GROUPS.PROFESSION [Специальность],
		PROGRESS.SUBJECT [Предмет],
		round(avg(cast(PROGRESS.NOTE AS float(4))), 2) [Средний балл]
	FROM GROUPS, STUDENT, PROFESSION, PROGRESS
	WHERE GROUPS.FACULTY in ('ХТиТ')
	GROUP BY GROUPS.FACULTY,
			 GROUPS.PROFESSION,
			 PROGRESS.SUBJECT;