export interface Docente{
   
        docenteId: number;
        docenteNombre: string;
        docenteApellido: string;
        escuelaId : number;
        titulo: string;
        especialidadDocente: any[];

           // public virtual Entidad DocenteNavigation { get; set; }
   // public virtual Escuela Escuela { get; set; }
     //   public virtual Asesor Asesor { get; set; }

}