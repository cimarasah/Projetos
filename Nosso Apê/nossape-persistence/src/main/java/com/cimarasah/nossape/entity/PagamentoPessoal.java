package com.cimarasah.nossape.entity;

import java.sql.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name="PAGAMENTO_PESSOAL")
public class PagamentoPessoal {
	
	@Id()
	private int id;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_DEBITO_PESSOAL", nullable=false)
	private DebitoPessoalMensal debitoPessoalMensal;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_MORADOR", nullable=false)
	private Morador morador;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_CONTA_FINAL", nullable=false)
	private ContaFinalMensal contaFinal;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_TIPO_PAGAMENTO", nullable=false)
	private TipoPagamento tipoPagamento;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_CAIXINHAL", nullable=false)
	private Caixinha caixinha;
	
	@Column(name="VL_PAGAMENTO")
	private double vlPagamento;
	
	@Column(name="DT_PAGAMENTO")
	private Date dtPagamento;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public DebitoPessoalMensal getDebitoPessoalMensal() {
		return debitoPessoalMensal;
	}

	public void setDebitoPessoalMensal(DebitoPessoalMensal debitoPessoalMensal) {
		this.debitoPessoalMensal = debitoPessoalMensal;
	}

	public Morador getMorador() {
		return morador;
	}

	public void setMorador(Morador morador) {
		this.morador = morador;
	}

	public ContaFinalMensal getContaFinal() {
		return contaFinal;
	}

	public void setContaFinal(ContaFinalMensal contaFinal) {
		this.contaFinal = contaFinal;
	}

	public TipoPagamento getTipoPagamento() {
		return tipoPagamento;
	}

	public void setTipoPagamento(TipoPagamento tipoPagamento) {
		this.tipoPagamento = tipoPagamento;
	}

	public Caixinha getCaixinha() {
		return caixinha;
	}

	public void setCaixinha(Caixinha caixinha) {
		this.caixinha = caixinha;
	}

	public double getVlPagamento() {
		return vlPagamento;
	}

	public void setVlPagamento(double vlPagamento) {
		this.vlPagamento = vlPagamento;
	}

	public Date getDtPagamento() {
		return dtPagamento;
	}

	public void setDtPagamento(Date dtPagamento) {
		this.dtPagamento = dtPagamento;
	}
}
