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
@Table(name="TIPO_TRANSACAO")
public class TipoTransacao {

	@Id()
	private int id;

	@Column(name="DS_DESCRICAO")
	private String descricao;
	
	@OneToMany(targetEntity=Caixinha.class, mappedBy="tipoTransacao")
	private Set<Caixinha> caixinhas;
	
	@OneToMany(targetEntity=Conta.class, mappedBy="tipoTransacao")
	private Set<Conta> contas;

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
	public Set<Caixinha> getCaixinhas() {
		return caixinhas;
	}

	public void setCaixinhas(Set<Caixinha> caixinhas) {
		this.caixinhas = caixinhas;
	}

	public Set<Conta> getContas() {
		return contas;
	}

	public void setContas(Set<Conta> contas) {
		this.contas = contas;
	}

}
