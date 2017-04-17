package com.cimarasah.nossape.entity;

import java.sql.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

/**
 * @author Cimara Sá
 *
 */
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

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public Cronograma getCronograma() {
		return cronograma;
	}

	public void setCronograma(Cronograma cronograma) {
		this.cronograma = cronograma;
	}

	public Morador getMorador() {
		return morador;
	}

	public void setMorador(Morador morador) {
		this.morador = morador;
	}

	public Atividade getAtividade() {
		return atividade;
	}

	public void setAtividade(Atividade atividade) {
		this.atividade = atividade;
	}

	public Date getDtInicio() {
		return dtInicio;
	}

	public void setDtInicio(Date dtInicio) {
		this.dtInicio = dtInicio;
	}

	public Date getDtFim() {
		return dtFim;
	}

	public void setDtFim(Date dtFim) {
		this.dtFim = dtFim;
	}

	public Date getDtRealizada() {
		return dtRealizada;
	}

	public void setDtRealizada(Date dtRealizada) {
		this.dtRealizada = dtRealizada;
	}

	public boolean isEnentoConcluido() {
		return enentoConcluido;
	}

	public void setEnentoConcluido(boolean enentoConcluido) {
		this.enentoConcluido = enentoConcluido;
	}

	public String getObservacao() {
		return observacao;
	}

	public void setObservacao(String observacao) {
		this.observacao = observacao;
	}
}
