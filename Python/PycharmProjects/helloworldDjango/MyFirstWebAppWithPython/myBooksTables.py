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


def create_table(conn, create_table_com):
    try:
        cursor = conn.cursor()
        cursor.execute(create_table_com)

    except Error as e:
        print(e)


def main():
    database = r"C:/users/owner/documents/sqlite3/db/books/myBooks.db"

    create_topics_table = """CREATE TABLE IF NOT EXISTS topics  
                             (
                                 id integer PRIMARY KEY AUTOINCREMENT,
                                 name text NOT NULL
                             );
                          """

    create_subtopics_table = """CREATE TABLE IF NOT EXISTS subtopics  
                                (
                                    id integer PRIMARY KEY AUTOINCREMENT,
                                    name text NOT NULL
                                );
                             """
    create_publishers_table = """CREATE TABLE IF NOT EXISTS publishers  
                                 (
                                     id integer PRIMARY KEY AUTOINCREMENT,
                                     name text NOT NULL,
                                     website text NOT NULL
                                 );
                              """

    create_authors_table = """CREATE TABLE IF NOT EXISTS authors  
                              (
                                  id integer PRIMARY KEY AUTOINCREMENT,
                                  first_name text NOT NULL,
                                  last_name text NOT NULL,
                                  email text 
                               );
                           """

    create_books_table = """CREATE TABLE IF NOT EXISTS books  
                            (
                                id integer PRIMARY KEY AUTOINCREMENT,
                                title text NOT NULL,
                                topic_id integer NOT NULL,
                                subtopic_id integer NOT NULL,
                                isbn text NOT NULL,
                                publisher_id integer NOT NULL,
                                author1 integer NOT NULL,
                                author2 integer NOT NULL,
                                author3 integer NOT NULL,
                                author4 integer NOT NULL,                               
                                price decimal NOT NULL,
                                front blob,
                                back blob,                                
                                FOREIGN KEY (topic_id) REFERENCES topics(id),
                                FOREIGN KEY (subtopic_id) REFERENCES subtopics(id),
                                FOREIGN KEY (publisher_id) REFERENCES publishers(id),
                                FOREIGN KEY (author1) REFERENCES authors(id),
                                FOREIGN KEY (author2) REFERENCES authors(id),
                                FOREIGN KEY (author3) REFERENCES authors(id),
                                FOREIGN KEY (author4) REFERENCES authors(id)                               
                            );                            
                         """

    conn = create_db_conn(database)

    if conn is None:
        print("Database connection failed!")
    else:
        create_table(conn, create_topics_table)
        print("topics table created successfully!")
        create_table(conn, create_subtopics_table)
        print("subtopics table created successfully!")
        create_table(conn, create_publishers_table)
        print("publishers table created successfully!")
        create_table(conn, create_authors_table)
        print("authors table created successfully!")
        create_table(conn, create_books_table)
        print("books table created successfully!")
        conn.close()
        print("Connection closed.")
        quit()

if __name__ == '__main__':
    main()
