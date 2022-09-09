using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class Compte
    {
        private int _numero;
        private string _nom;
        private float _solde;
        private float _decouvert;

        public Compte(int numero, string nom, float solde, float decouvert)
        {
            this._numero = numero;
            this._nom = nom;
            this._solde = solde;
            this._decouvert = decouvert;
        }
        public void Transferer(double montant,Compte c)
        {

        }
        public bool Superieur(Compte c)
        {
            return false;
        }

        public void Crediter(double montant)
        {

        }

        public void Debiter(double montant)
        {

        }
    }
}
