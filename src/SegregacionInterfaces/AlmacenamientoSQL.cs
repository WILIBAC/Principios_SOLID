﻿using System;
using System.IO;

namespace SegregacionInterfaces
{
    public class AlmacenamientoSQL : IAlmacenamiento
    {
        private DBRepository _dBRepository;
        public AlmacenamientoSQL()
        {
            _dBRepository = new DBRepository();
        }

        public void Guardar(string titulo, string contenido)
        {
            _dBRepository.Guardar(titulo, contenido);
        }

        public string Leer(string titulo)
        {
            return _dBRepository.Leer(titulo);
        }
    }
}
