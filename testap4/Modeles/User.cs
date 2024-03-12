﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testap4.Modeles
{
    public class User
    {
        #region Attributs

        private int _id;
        private string _email;
        private string _nom;
        private string _prenom;
        private string _password;
        private string _telephone;
        private DateTime _dateNaissance;

        #endregion

        #region Constructeurs

        public User() { }

        public User(int id, string email, string nom, string prenom, string password, string telephone, DateTime dateNaissance)
        {
            _id = id;
            _email = email;
            _nom = nom;
            _prenom = prenom;
            _password = password;
            _telephone = telephone;
            _dateNaissance = dateNaissance;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("email")]
        public string Email { get => _email; set => _email = value; }

        [JsonProperty("nom")]
        public string Nom { get => _nom; set => _nom = value; }

        [JsonProperty("prenom")]
        public string Prenom { get => _prenom; set => _prenom = value; }

        [JsonProperty("password")]
        public string Password { get => _password; set => _password = value; }

        [JsonProperty("telephone")]
        public string Telephone { get => _telephone; set => _telephone = value; }

        [JsonProperty("dateNaissance")]
        public DateTime DateNaissance { get => _dateNaissance; set => _dateNaissance = value; }

        #endregion

        #region Methodes

        // Vous pouvez ajouter ici des méthodes spécifiques à l'utilisateur si nécessaire

        #endregion
    }
}
