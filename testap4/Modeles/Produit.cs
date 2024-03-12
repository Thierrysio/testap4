using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testap4.Modeles
{
    public class Produit
    {
        #region Attributs


        private int _id;
        private string _nomProduit;
        private float _prixProduit;
        private int _pointsFidelite;
        #endregion

        #region Constructeurs

        public Produit(int id, string nomProduit, float prixProduit, int pointsFidelite)
        {
            _id = id;
            _nomProduit = nomProduit;
            _prixProduit = prixProduit;
            _pointsFidelite = pointsFidelite;
        }

        #endregion

        #region Getters/Setters
        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("nomProduit")] 
        public string NomProduit { get => _nomProduit; set => _nomProduit = value; }
        [JsonProperty("prixProduit")] 
        public float PrixProduit { get => _prixProduit; set => _prixProduit = value; }
        [JsonProperty("pointsFidelite")] 
        public int PointsFidelite { get => _pointsFidelite; set => _pointsFidelite = value; }


        #endregion

        #region Methodes

        #endregion
    }
}
