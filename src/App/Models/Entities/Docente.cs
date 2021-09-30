using System;
using App.Models.Enums;
using App.Models.ValueTypes;
using SequentialGuid;

namespace App.Models.Entities
{
    public partial class Docente
    {
        public Docente(string NominativoDocente, string MateriaInsegnata)
        {
            IdDocente = SequentialGuidGenerator.Instance.NewGuid().ToString();
            ChangeNominativoDocente(NominativoDocente);
            ChangeMateriaInsegnata(MateriaInsegnata);
            Telefono = "";
            Email = "";
            Residenza = "";
            CodiceCorso = "";
            CodiceDipartimento = "";
            CostoOrario = new Money(Currency.EUR, 0);
        }

        public int Id { get; set; }
        public string IdDocente { get; set; }
        public string NominativoDocente { get; set; }
        public string MateriaInsegnata { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Residenza { get; set; }
        public string CodiceCorso { get; set; }
        public string CodiceDipartimento { get; set; }
        public Money CostoOrario { get; set; }

        public void ChangeNominativoDocente(string newNominativoDocente)
        {
            if (string.IsNullOrWhiteSpace(newNominativoDocente))
            {
                throw new ArgumentException("Il docente deve avere un nominativo");
            }

            NominativoDocente = newNominativoDocente;
        }

        public void ChangeMateriaInsegnata(string newMateriaInsegnata)
        {
            if (string.IsNullOrWhiteSpace(newMateriaInsegnata))
            {
                throw new ArgumentException("Il docente deve avere una materia di insegnamento");
            }

            MateriaInsegnata = newMateriaInsegnata;
        }

        public void ChangeTelefono(string newTelefono)
        {
            if (string.IsNullOrWhiteSpace(newTelefono))
            {
                throw new ArgumentException("Il docente deve avere una materia di insegnamento");
            }

            Telefono = newTelefono;
        }

        public void ChangeEmail(string newEmail)
        {
            if (string.IsNullOrEmpty(newEmail))
            {
                throw new ArgumentException("Il docente deve avere un indirizzo email");
            }

            Email = newEmail;
        }

        public void ChangeResidenza(string newResidenza)
        {
            if (string.IsNullOrEmpty(newResidenza))
            {
                throw new ArgumentException("Il docente deve avere una residenza");
            }

            Residenza = newResidenza;
        }

        public void ChangeCodiceCorso(string newCodiceCorso)
        {
            if (string.IsNullOrEmpty(newCodiceCorso))
            {
                throw new ArgumentException("Il docente deve aver assegnato ad un corso");
            }
            
            CodiceCorso = newCodiceCorso;
        }

        public void ChangeCodiceDipartimento(string newCodiceDipartimento)
        {
            if (string.IsNullOrEmpty(newCodiceDipartimento))
            {
                throw new ArgumentException("Il docente aver assegnato una dipartimento");
            }
            
            CodiceDipartimento = newCodiceDipartimento;
        }

        public void ChangeCostoOrario(Money newCostoOrario)
        {
            CostoOrario = newCostoOrario;
        }
    }
}