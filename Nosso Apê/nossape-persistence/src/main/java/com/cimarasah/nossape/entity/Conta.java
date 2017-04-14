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
@Table(name="CONTA")
public class Conta {

	@Id()
	private int id;
	
	@Column(name="DS_DESCRICAO")
	private String descricao;
	
	@Column(name="VL_BASE")
	private double vlBase;

	@Column(name="NU_DIA_PAGAMENTO")
	private int diaPagamento;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_TIPO_TRANSACAO", nullable=false)
	private TipoTransacao tipoTransacao;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_TIPO_DIVISAO", nullable=false)
	private TipoDivisaoConta tipoDivisao;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_TIPO_VARIACAO", nullable=false)
	private TipoVariacaoConta tipoVariacao;
	
	@OneToMany(targetEntity=ContaMensal.class, mappedBy="conta")
	private Set<ContaMensal> contasMensais;

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

	public double getVlBase() {
		return vlBase;
	}

	public void setVlBase(double vlBase) {
		this.vlBase = vlBase;
	}

	public int getDiaPagamento() {
		return diaPagamento;
	}

	public void setDiaPagamento(int diaPagamento) {
		this.diaPagamento = diaPagamento;
	}

	public TipoTransacao getTipoTransacao() {
		return tipoTransacao;
	}

	public void setTipoTransacao(TipoTransacao tipoTransacao) {
		this.tipoTransacao = tipoTransacao;
	}

	public TipoDivisaoConta getTipoDivisao() {
		return tipoDivisao;
	}

	public void setTipoDivisao(TipoDivisaoConta tipoDivisao) {
		this.tipoDivisao = tipoDivisao;
	}

	public TipoVariacaoConta getTipoVariacao() {
		return tipoVariacao;
	}

	public void setTipoVariacao(TipoVariacaoConta tipoVariacao) {
		this.tipoVariacao = tipoVariacao;
	}

	public Set<ContaMensal> getContasMensais() {
		return contasMensais;
	}

	public void setContasMensais(Set<ContaMensal> contasMensais) {
		this.contasMensais = contasMensais;
	}
	
}
