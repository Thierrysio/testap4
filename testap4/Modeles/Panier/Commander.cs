using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testap4.Modeles.Panier
{
    public class Commander
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("quantite")]
        public int Quantite { get; set; }

        [JsonProperty("leProduit")]
        public Produit LeProduit { get; set; }
    }
}
