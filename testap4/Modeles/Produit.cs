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
        private bool _isSelected;
        #endregion

        #region Constructeurs

        public Produit(int id, string nomProduit, float prixProduit, int pointsFidelite)
        {
            _id = id;
            _nomProduit = nomProduit;
            _prixProduit = prixProduit;
            _pointsFidelite = pointsFidelite;
            _isSelected = false;
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

        public bool IsSelected { get => _isSelected; set => _isSelected = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
