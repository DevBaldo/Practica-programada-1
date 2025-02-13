using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class Persona
{
    public int Id { get; set; }

    public string Identificacion { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string PrimerApellido { get; set; } = null!;

    public string SegundoApellido { get; set; } = null!;
}
