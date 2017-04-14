package com.cimarasah.nossape.entity;

import java.sql.Date;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name="MORADOR")
public class Morador {

	@Id()	
	private int id;

	@Column(name="DS_NOME")
	private String nome;
	
	@Column(name="DT_NASCIMENTO")
	private Date dtNascimento;

	@Column(name="DS_TELEFONE")
	private String telefone;
	
	@Column(name="DS_EMAIL")
	private String email;
	
	@Column(name="DS_SENHA")
	private String senha;

	@Column(name="FL_DIVIDE_QTO")
	private boolean divideQuarto;
	
	@Column(name="VL_QTD_POR_QTO")
	private double valorPorQuarto;	
	
	@Column(name="FL_ATIVO")
	private boolean ativo;
	
	@Column(name="NM_DIA_LIMPEZA")
	private int diaLimpeza;
	
	@ManyToOne()
	@JoinColumn(name="FK_ID_TIPO_MORADOR", nullable=false)
	private TipoMorador tipoMorador;
	
	@OneToMany(targetEntity=DebitoPessoalMensal.class, mappedBy="morador")
	private Set<DebitoPessoalMensal> debitosPessoalMensal;
	
	@OneToMany(targetEntity=PagamentoConta.class, mappedBy="morador")
	private Set<PagamentoConta> pagamentosContas;
	
	@OneToMany(targetEntity=Evento.class, mappedBy="morador")
	private Set<Evento> eventos;
	
	@OneToMany(targetEntity=PagamentoConta.class, mappedBy="morador")
	private Set<PagamentoPessoal> pagamentosPessoal;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public Date getDtNascimento() {
		return dtNascimento;
	}

	public void setDtNascimento(Date dtNascimento) {
		this.dtNascimento = dtNascimento;
	}

	public String getTelefone() {
		return telefone;
	}

	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getSenha() {
		return senha;
	}

	public void setSenha(String senha) {
		this.senha = senha;
	}

	public boolean isDivideQuarto() {
		return divideQuarto;
	}

	public void setDivideQuarto(boolean divideQuarto) {
		this.divideQuarto = divideQuarto;
	}

	public double getValorPorQuarto() {
		return valorPorQuarto;
	}

	public void setValorPorQuarto(double valorPorQuarto) {
		this.valorPorQuarto = valorPorQuarto;
	}

	public TipoMorador getTipoMorador() {
		return tipoMorador;
	}

	public void setTipoMorador(TipoMorador tipoMorador) {
		this.tipoMorador = tipoMorador;
	}

	public boolean isAtivo() {
		return ativo;
	}

	public void setAtivo(boolean ativo) {
		this.ativo = ativo;
	}

	public int getDiaLimpeza() {
		return diaLimpeza;
	}

	public void setDiaLimpeza(int diaLimpeza) {
		this.diaLimpeza = diaLimpeza;
	}

	public Set<DebitoPessoalMensal> getDebitosPessoalMensal() {
		return debitosPessoalMensal;
	}

	public void setDebitosPessoalMensal(Set<DebitoPessoalMensal> debitosPessoalMensal) {
		this.debitosPessoalMensal = debitosPessoalMensal;
	}

	public Set<Evento> getEventos() {
		return eventos;
	}

	public void setEventos(Set<Evento> eventos) {
		this.eventos = eventos;
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
