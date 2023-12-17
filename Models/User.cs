using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Move using directives to the top of the file
public class User
{
    public int id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public DateTime dob { get; set; }
    public string address { get; set; }
    public bool is_active { get; set; }
    public string profile_picture { get; set; }
}
