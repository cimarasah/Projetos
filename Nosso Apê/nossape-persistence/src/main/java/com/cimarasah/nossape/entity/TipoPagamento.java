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
@Table(name="TIPO_PAGAMENTO")
public class TipoPagamento {
	
	@Id()
	private int id;

	@Column(name="DS_DESCRICAO")
	private String descricao;
	
	@OneToMany(targetEntity=PagamentoConta.class, mappedBy="tipoPagamento")
	private Set<PagamentoConta> pagamentosContas;
	
	@OneToMany(targetEntity=PagamentoConta.class, mappedBy="tipoPagamento")
	private Set<PagamentoPessoal> pagamentosPessoal;

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

	public Set<PagamentoConta> getPagamentosContas() {
		return pagamentosContas;
	}

	public void setPagamentosContas(Set<PagamentoConta> pagamentosContas) {
		this.pagamentosContas = pagamentosContas;
	}

	public Set<PagamentoPessoal> getPagamentosPessoal() {
		return pagamentosPessoal;
	}

	public void setPagamentosPessoal(Set<PagamentoPessoal> pagamentosPessoal) {
		this.pagamentosPessoal = pagamentosPessoal;
	}

}
