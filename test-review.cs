using System.Linq;
using System;
public class Test2
{
    public string Get()
    {
        return _db.Users.FirstOrDefaultAsync(x => x.Id == 1).Result;
    }
}
