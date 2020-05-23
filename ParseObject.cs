using JsonTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest
{
    public class ParseObject
    {
        public ParseObject()
        { }

        public List<string> Handle(Recipents result)
        {
            List<Recipent> listMoreThanOne = result.recipients.Where(x => x.tags.Count > 1).ToList();
            List<string> listMatchedUser   = new List<string>();

            if (listMoreThanOne.Count == 0)
                return listMatchedUser;

            int row   = listMoreThanOne.Count;
            int count = 0;

            while (count < row)
            {
                for (int i = count + 1; i < row; i++)
                {
                    var list1 = listMoreThanOne[count].tags;
                    var list2 = listMoreThanOne[i].tags;

                    var match = list1.Where(x => list2.Any(z => z.Equals(x)));
                    if (match.Count() > 1)
                    {
                        string matchUsersName    = string.Format("{0},{1}", listMoreThanOne[count].name, listMoreThanOne[i].name);
                        string repeatedUsersName = string.Format("{0},{1}", listMoreThanOne[i].name, result.recipients[count].name);

                        if (!listMatchedUser.Contains(matchUsersName) && !listMatchedUser.Contains(repeatedUsersName))
                            listMatchedUser.Add(matchUsersName);
                    }
                }

                count++;
            }


            return listMatchedUser;
           
        }
    }
}
