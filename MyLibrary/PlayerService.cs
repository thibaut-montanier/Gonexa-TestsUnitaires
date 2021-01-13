using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary {
    public class PlayerService {


        public virtual List<Player> getAll() {
            throw new NotImplementedException();
        }

        public string getPlayerLst() {
            return string.Join("\n",
                this.getAll().Select(p=>$"Nom : {p.Name}, prenom : {p.FirstName}"));
        }
    }
}
