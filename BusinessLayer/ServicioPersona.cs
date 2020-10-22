using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.PersistentHelper;

namespace BusinessLayer
{
    public class ServicioPersona
    {
        private readonly Serializer serializer;
        private readonly string Directory;
        private readonly string FileName;
        public ServicioPersona()
        {
            serializer = new Serializer();
            Directory = "persons";
            FileName = "persons.dat";

        }

        public void Add(Persona item)
        {
            RepositorioPersona.Instacia.Personas.Add(item);
            serializer.Serialize(RepositorioPersona.Instacia.Personas,Directory,FileName);
        }

        public void Edit(int index,Persona item)
        {
            RepositorioPersona.Instacia.Personas[index] = item;
            serializer.Serialize(RepositorioPersona.Instacia.Personas, Directory, FileName);
        }

        public void Delete(int index)
        {
            RepositorioPersona.Instacia.Personas.RemoveAt(index);
            serializer.Serialize(RepositorioPersona.Instacia.Personas, Directory, FileName);
        }

        public Persona GetItem(int index)
        {
            return RepositorioPersona.Instacia.Personas[index];
        }

        public List<Persona> GetList()
        {
            List<Persona> listadoPersonas = (List<Persona>)serializer.Deserialize(Directory, FileName);

            if (listadoPersonas != null)
            {
                RepositorioPersona.Instacia.Personas = listadoPersonas;
            }

            return RepositorioPersona.Instacia.Personas;
        }


    }
}
