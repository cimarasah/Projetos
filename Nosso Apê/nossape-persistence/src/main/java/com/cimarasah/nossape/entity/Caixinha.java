package com.cimarasah.nossape.entity;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name="CAIXINHA")
public class Caixinha {

	@Id()
	private int id;

	@ManyToOne()
	@JoinColumn(name="FK_ID_TIPO_TRANSACAO", nullable=false)
	private TipoTransacao tipoTransacao;
	
	@Column(name="VL_TOTAL")
	private double vlTotal;
	
	@OneToMany(targetEntity=PagamentoConta.class, mappedBy="caixinha")
	private Set<PagamentoConta> pagamentosContas;

	@OneToMany(targetEntity=PagamentoPessoal.class, mappedBy="caixinha")
	private Set<PagamentoPessoal> pagamentosPessoal;
	
	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public TipoTransacao getTipoTransacao() {
		return tipoTransacao;
	}

	public void setTipoTransacao(TipoTransacao tipoTransacao) {
		this.tipoTransacao = tipoTransacao;
	}


	public double getVlTotal() {
		return vlTotal;
	}

	public void setVlTotal(double vlTotal) {
		this.vlTotal = vlTotal;
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
