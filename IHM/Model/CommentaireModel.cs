﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IHM.Model
{
    public class CommentaireModel { }

    public class Commentaire : Base
    {
        private int Id { get; set; }
        private string filmFK;
        private string utilisateurFK;

        public string FilmFK
        {
            get
            {
                return filmFK;
            }

            set
            {
                if (filmFK != value)
                {
                    filmFK = value;
                    RaisePropertyChanged("FilmFK");
                    RaisePropertyChanged("InfosCommentaire");
                }
            }
        }

        public string UtilisateurFK
        {
            get { return utilisateurFK; }

            set
            {
                if (utilisateurFK != value)
                {
                    utilisateurFK = value;
                    RaisePropertyChanged("UtilisateurFK");
                    RaisePropertyChanged("InfosCommentaire");
                }
            }
        }

        public string InfosCommentaire
        {
            get
            {
                return  "id" + Id + "filmFK :  " + filmFK + ". utilisateurFK : " + utilisateurFK;
            }
        }
    }
}
