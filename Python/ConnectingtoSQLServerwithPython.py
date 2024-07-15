import pyodbc
conn = pyodbc.connect('Driver={SQL Server};'
					  'Server=DESKTOP-UADQUEE\SQLEXPRESS01;'
					  'Database=myBooksLibrary;'
					  'Trusted_Connection=yes;')

sqlstr =          'SELECT B.TITTLE AS "BOOK TITTLE", '
sqlstr = sqlstr + "FORMAT(B.PRICE,'C','en-us') AS 'PRICE', "
sqlstr = sqlstr + 'B.ISBN AS "ISBN", '
sqlstr = sqlstr + 'P.NAME AS "PUBLISHER", '
sqlstr = sqlstr + 'T.NAME AS "TOPIC", '
sqlstr = sqlstr + 'S.NAME AS "SUBTOPIC", '
sqlstr = sqlstr + 'A.FIRST_NAME + ' + " " + 'A.LAST_NAME AS "AUTHOR" '
sqlstr = sqlstr + 'FROM BOOKS AS B '
sqlstr = sqlstr + 'INNER JOIN '
sqlstr = sqlstr + 'TOPICS AS T ON B.TOPIC_ID = T.ID '
sqlstr = sqlstr + 'INNER JOIN '
sqlstr = sqlstr + 'SUBTOPICS AS S ON B.SUBTOPIC_ID = S.ID '
sqlstr = sqlstr + 'INNER JOIN '
sqlstr = sqlstr + 'PUBLISHERS AS P ON B.PUBLISHER_ID = P.ID '
sqlstr = sqlstr + 'INNER JOIN '
sqlstr = sqlstr + 'AUTHORS AS A ON B.AUTHOR1_ID = A.ID'

cursor=conn.cursor()
cursor.execute(sqlstr)
                        
for row in cursor:
	print(row)

					  
#        SELECT B.TITTLE AS "BOOK TITTLE", 
#               FORMAT(B.PRICE,'C','en-us') AS "PRICE", 
#               B.ISBN AS "ISBN",
#               P.NAME AS "PUBLISHER",
#               T.NAME AS "TOPIC", 
#               S.NAME AS "SUBTOPIC", 
#               A.FIRST_NAME + ' ' + A.LAST_NAME AS "AUTHOR"
#
#        FROM BOOKS AS B
#        INNER JOIN
#             TOPICS AS T ON B.TOPIC_ID = T.ID
#        INNER JOIN
#             SUBTOPICS AS S ON B.SUBTOPIC_ID = S.ID
#        INNER JOIN
#             PUBLISHERS AS P ON B.PUBLISHER_ID = P.ID
#        INNER JOIN
#             AUTHORS AS A ON B.AUTHOR1_ID = A.ID
