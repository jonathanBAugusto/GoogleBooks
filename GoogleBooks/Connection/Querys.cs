namespace GoogleBooks.Connection
{
    class Querys
    {
        public static string TABLE_FAVORITOS = @"
        CREATE TABLE IF NOT EXISTS Favoritos(
            id varchar(15) primary key,
            title varchar(150),
            description TEXT,
            thumbnail TEXT,
            small_thumbnail TEXT
        );
        ";
    }
}
