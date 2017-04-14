package com.cimarasah.nossape.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="TIPO_MORADOR")
public class TipoMorador {

	@Id()
	private String id;

	@Column(name="DS_DESCRICAO")
	private String descricao;

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getDescricao() {
		return descricao;
	}

	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}
}
