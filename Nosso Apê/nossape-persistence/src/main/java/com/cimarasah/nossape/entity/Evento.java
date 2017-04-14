package com.cimarasah.nossape.entity;

import java.sql.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name="EVENTO")
public class Evento {

	@Id()
	private int id;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_CRONOGRAMA", nullable=false)
	private Cronograma cronograma;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_MORADOR", nullable=false)
	private Morador morador;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_ATIVIDADE", nullable=false)
	private Atividade atividade;
	
	@Column(name="DT_INICIO")
	private Date dtInicio;
	
	@Column(name="DT_FIM")
	private Date dtFim;
	
	@Column(name="DT_REALIZADA")
	private Date dtRealizada;
	
	@Column(name="FL_CONCLUIDA")
	private boolean enentoConcluido;
	
	@Column(name="DS_OBSERVACAO")
	private String observacao;
}
