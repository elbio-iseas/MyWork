import sqlite3
from sqlite3 import Error


def create_db_conn(db_file):

    conn = None
    try:
        conn = sqlite3.connect(db_file)
        print("Database connection successful.")
    except Error as e:
        print(e)

    return conn


def add_rows_to_table(conn, adding_records):
    try:
        cursor = conn.cursor()
        cursor.executescript(adding_records)

    except Error as e:
        print(e)


def main():
    database = r"C:/users/owner/documents/sqlite3/db/books/myBooks.db"

    conn = create_db_conn(database)

    adding_topics = """INSERT INTO TOPICS (id, name) 
                        VALUES (1, "ASP.NET"),
                               (2, "JAVA"),
                               (3, "PYTHON"), 
                               (4, "JAVASCRIPT"),
                               (5, "REGULAR EXPRESSIONS"),
                               (6, "C++"),
                               (7, "XML"),
                               (8, "TURBO PROLOG"),
                               (9, "VISUAL BASIC.NET"),
                               (10, "VISUAL BASIC 6.0");
                               """
    #print(adding_topics)

    adding_subtopics = """INSERT INTO SUBTOPICS (id, name) 
                            VALUES (1, "ASP.NET MVC"),
                                   (2, "JAVA OBJECT ORIENTED PROGRAMMING"),
                                   (3, "PYTHON FOR DUMMIES"), 
                                   (4, "JAVASCRIPT 10 STEPS OR LESS"),
                                   (5, "REGULAR EXPRESSIONS BEGINNING"),
                                   (6, "C++ PROGRAMMING"),
                                   (7, "XML FOR DUMMIES"),
                                   (8, "TURBO PROLOG REFERENCE'S GUIDE"),
                                   (9, "VISUAL BASIC.NET OOP"),
                                   (10, "VISUAL BASIC 6.0 DATABASE PROGRAMMING ");
                                   """
    print(adding_subtopics)

    if conn is None:
        print("Database connection failed!")
    else:
        #add_rows_to_table(conn, adding_topics)
        #print("topics added!")
        add_rows_to_table(conn, adding_subtopics)
        print("subtopics added!")
        """
        add_rows_to_table(conn, adding_publishers)
        print("publishers added!")
        add_rows_to_table(conn, adding_authors)
        print("authors added!")
        add_rows_to_table(conn, adding_books)
        print("books added!")
        """
        conn.close()
        print("Connection closed.")
        quit()


if __name__ == '__main__':
    main()
