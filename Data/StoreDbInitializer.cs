namespace assignment_3.Data
{
    public class StoreDbInitializer
    {
        public static void Initilaizer(StoreDbContext context) //kan kalle funskjonene uten å bruke object av klassen
        { 
            
            // Delete the database before we initialize it. This is common to do during development.
            context.Database.EnsureDeleted(); //tømmer databasen 
         
            // Make sure the database and tables exist
            context.Database.EnsureCreated(); //lager databasen 
         
                
         
            // Finally save changes to the database
            context.SaveChanges(); //lagrer endingene som er blitt gjort i databasen 
            
        }

    }
}