
SELECT * FROM [dbo].[Curso]
SELECT * FROM [dbo].[Precio]
SELECT * FROM [dbo].[Comentario]


ALTER TABLE Comentario
	ADD CONSTRAINT FK_COMENTARIO_CURSO
		FOREIGN KEY(CursoId) REFERENCES Curso(CursoId)


ALTER TABLE CursoInstructor
	ADD CONSTRAINT FK_CURSO_INSTRUCTOR_CURSOID
		FOREIGN KEY(CursoId) REFERENCES dbo.Curso(CursoId)

ALTER TABLE CursoInstructor
	ADD CONSTRAINT FK_CURSO_INSTRUCTOR_INSTRUCTOROID
		FOREIGN KEY(InstructorId) REFERENCES dbo.Instructor(InstructorId)