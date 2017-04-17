package com.cimarasah.nossape.entity;

import java.sql.Date;
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
@Table(name="CONTA_FINAL_MENSAL")
public class ContaFinalMensal {

	@Id()
	private int id;

	@Column(name="DT_MES")
	private Date dtMes;
	
	@Column(name="VL_MES")
	private double vlMes;
	
	@OneToMany(targetEntity=ContaMensal.class, mappedBy="contaFinal")
	private Set<ContaMensal> contasMensais;
	
	@OneToMany(targetEntity=DebitoPessoalMensal.class, mappedBy="contaFinal")
	private Set<DebitoPessoalMensal> DebitosPessoalMensal;
	
	@OneToMany(targetEntity=PagamentoPessoal.class, mappedBy="contaFinal")
	private Set<PagamentoPessoal> pagamentosPessoal;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public Date getDtMes() {
		return dtMes;
	}

	public void setDtMes(Date dtMes) {
		this.dtMes = dtMes;
	}

	public double getVlMes() {
		return vlMes;
	}

	public void setVlMes(double vlMes) {
		this.vlMes = vlMes;
	}

	public Set<ContaMensal> getContasMensais() {
		return contasMensais;
	}

	public void setContasMensais(Set<ContaMensal> contasMensais) {
		this.contasMensais = contasMensais;
	}

	public Set<DebitoPessoalMensal> getDebitosPessoalMensal() {
		return DebitosPessoalMensal;
	}

	public void setDebitosPessoalMensal(Set<DebitoPessoalMensal> debitosPessoalMensal) {
		DebitosPessoalMensal = debitosPessoalMensal;
	}

	public Set<PagamentoPessoal> getPagamentosPessoal() {
		return pagamentosPessoal;
	}

	public void setPagamentosPessoal(Set<PagamentoPessoal> pagamentosPessoal) {
		this.pagamentosPessoal = pagamentosPessoal;
	}
}
