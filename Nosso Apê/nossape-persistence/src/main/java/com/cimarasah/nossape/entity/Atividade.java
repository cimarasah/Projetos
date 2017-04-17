package com.cimarasah.nossape.entity;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;
/**
 * @author Cimara Sá
 *
 */
@Entity
@Table(name="ATIVIDADE")
public class Atividade {

	@Id()
	private int id;

	@Column(name="DS_DESCRICAO")
	private String descricao;

	@ManyToOne()
	@JoinColumn(name="FK_ID_PERIODICIDADE", nullable=false)
	private TipoPeriodicidade tipoPeriodicidade;

	@OneToMany(targetEntity=Evento.class, mappedBy="atividade")
	private Set<Evento> eventos;

	public int getId() {
		return id;
	}


	public void setId(int id) {
		this.id = id;
	}


	public String getDescricao() {
		return descricao;
	}


	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}


	public TipoPeriodicidade getTipoPeriodicidade() {
		return tipoPeriodicidade;
	}


	public void setTipoPeriodicidade(TipoPeriodicidade tipoPeriodicidade) {
		this.tipoPeriodicidade = tipoPeriodicidade;
	}


	public Set<Evento> getEventos() {
		return eventos;
	}


	public void setEventos(Set<Evento> eventos) {
		this.eventos = eventos;
	}

}
