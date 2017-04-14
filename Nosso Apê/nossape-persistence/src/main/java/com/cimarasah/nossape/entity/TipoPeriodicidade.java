package com.cimarasah.nossape.entity;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name="TIPO_PERIODICIDADE")
public class TipoPeriodicidade {

	@Id()
	private int id;

	@Column(name="DS_PERIODICIDADE")
	private String periodicidade;
	
	@OneToMany(targetEntity=Atividade.class, mappedBy="tipoPeriodicidade")
	private Set<Atividade> atividades;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getPeriodicidade() {
		return periodicidade;
	}

	public void setPeriodicidade(String periodicidade) {
		this.periodicidade = periodicidade;
	}

	public Set<Atividade> getAtividades() {
		return atividades;
	}

	public void setAtividades(Set<Atividade> atividades) {
		this.atividades = atividades;
	}
}
