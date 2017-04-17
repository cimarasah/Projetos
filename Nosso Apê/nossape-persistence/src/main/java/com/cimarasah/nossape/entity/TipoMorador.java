package com.cimarasah.nossape.entity;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

/**
 * @author Cimara Sá
 *
 */
@Entity
@Table(name="TIPO_MORADOR")
public class TipoMorador {

	@Id()
	private int id;

	@Column(name="DS_DESCRICAO")
	private String descricao;
	
	@OneToMany(targetEntity=Morador.class, mappedBy="tipoMorador")
	private Set<Morador> moradores;

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

	public Set<Morador> getMoradores() {
		return moradores;
	}

	public void setMoradores(Set<Morador> moradores) {
		this.moradores = moradores;
	}
}
