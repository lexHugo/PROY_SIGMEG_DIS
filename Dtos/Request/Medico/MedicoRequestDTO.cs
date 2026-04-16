// Modificar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SGMG.Dtos.Request.Medico
{
  public class MedicoRequestDTO
  {
    public int? IdMedico { get; set; }

    [Required(ErrorMessage = "El número de DNI es obligatorio")]
    [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "El DNI debe contener solo 8 dígitos")]
    public string NumeroDni { get; set; } = "";

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 50 caracteres")]
    [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El nombre solo puede contener letras y espacios")]
    public string Nombre { get; set; } = "";

    [Required(ErrorMessage = "El apellido paterno es obligatorio")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "El apellido paterno debe tener entre 2 y 50 caracteres")]
    [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El apellido paterno solo puede contener letras y espacios")]
    public string ApellidoPaterno { get; set; } = "";

    [StringLength(100, MinimumLength = 2, ErrorMessage = "El apellido materno debe tener entre 2 y 100 caracteres")]
    [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El apellido materno solo puede contener letras y espacios")]
    public string? ApellidoMaterno { get; set; }

    [Required(ErrorMessage = "El sexo es obligatorio")]
    [RegularExpression("^(M|F)$", ErrorMessage = "El sexo debe ser M (Masculino) o F (Femenino)")]
    public string Sexo { get; set; } = "";

    [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
    [DataType(DataType.Date, ErrorMessage = "La fecha de nacimiento debe estar en formato yyyy-MM-dd")]
    public DateTime FechaNacimiento { get; set; }

    [StringLength(200, ErrorMessage = "La dirección no puede exceder 200 caracteres")]
    [RegularExpression(@"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑ\s.,#-]+$", ErrorMessage = "La dirección contiene caracteres no válidos")]
    public string? Direccion { get; set; }

    [Phone(ErrorMessage = "El formato del teléfono no es válido")]
    [StringLength(15, MinimumLength = 7, ErrorMessage = "El teléfono debe tener entre 7 y 15 caracteres")]
    [RegularExpression(@"^\+?[0-9]{7,15}$", ErrorMessage = "El teléfono solo puede contener números y opcionalmente el símbolo + al inicio")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "El correo electrónico es obligatorio")]
    [StringLength(100, ErrorMessage = "El correo electrónico no puede exceder 100 caracteres")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "El formato del correo electrónico no es válido")]
    public string CorreoElectronico { get; set; } = "";

    [Required(ErrorMessage = "El estado laboral es obligatorio")]
    [RegularExpression("^(Activo|Inactivo|Licencia|Vacaciones)$", ErrorMessage = "El estado laboral debe ser: Activo, Inactivo, Licencia o Vacaciones")]
    public string EstadoLaboral { get; set; } = "";

    [Required(ErrorMessage = "La fecha de ingreso es obligatoria")]
    [DataType(DataType.Date, ErrorMessage = "La fecha de ingreso debe estar en formato yyyy-MM-dd")]
    public DateTime FechaIngreso { get; set; }

    [Required(ErrorMessage = "El turno es obligatorio")]
    [RegularExpression("^(Mañana|Tarde|Noche|Rotativo)$", ErrorMessage = "El turno debe ser: Mañana, Tarde, Noche o Rotativo")]
    public string Turno { get; set; } = "";

    [Required(ErrorMessage = "El área de servicio es obligatoria")]
    [StringLength(100, ErrorMessage = "El área de servicio no puede exceder 100 caracteres")]
    [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El área de servicio solo puede contener letras y espacios")]
    public string AreaServicio { get; set; } = "";

    [Required(ErrorMessage = "El cargo médico es obligatorio")]
    [StringLength(100, ErrorMessage = "El cargo médico no puede exceder 100 caracteres")]
    [RegularExpression(@"^[A-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El cargo médico solo puede contener letras mayúsculas y espacios")]
    public string CargoMedico { get; set; } = "";

    [Required(ErrorMessage = "El número de colegiatura es obligatorio")]
    [StringLength(20, MinimumLength = 5, ErrorMessage = "El número de colegiatura debe tener entre 5 y 20 caracteres")]
    [RegularExpression(@"^[A-Z0-9\-]+$", ErrorMessage = "El número de colegiatura solo puede contener letras mayúsculas, números y guiones")]
    public string NumeroColegiatura { get; set; } = "";

    [Required(ErrorMessage = "El tipo de médico es obligatorio")]
    [RegularExpression("^(General|Especialista|Residente|Interno)$", ErrorMessage = "El tipo de médico debe ser: General, Especialista, Residente o Interno")]
    public string TipoMedico { get; set; } = "";

    [Required(ErrorMessage = "El ID del consultorio es obligatorio")]
    [Range(1, int.MaxValue, ErrorMessage = "El ID del consultorio debe ser un número positivo")]
    public int? IdConsultorio { get; set; }
  }
}
