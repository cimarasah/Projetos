package com.cimarasah.nossape.fachada.impl;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;

import com.cimarasah.nossape.converter.MoradorConverter;
import com.cimarasah.nossape.dto.MoradorDTO;
import com.cimarasah.nossape.fachada.IMoradorFachada;
import com.cimarasah.nossape.repository.IMoradorRepository;

public class MoradorFachada implements IMoradorFachada{

	@Autowired
	MoradorConverter converter;
	
	@Autowired
	IMoradorRepository repository;
	
	@Override
	public List<MoradorDTO> listarMorador() {
		return converter.getListDTO(repository.findAll());
	}

	@Override
	public MoradorDTO buscarMoradorPorId(int id) {		
		return converter.getDTO(repository.findById(id));
	}

	@Override
	public List<MoradorDTO> buscarMoradorPorNome(String nome) {
		return converter.getListDTO(repository.findByNome(nome));
	}

	@Override
	public void salvarMorador(MoradorDTO morador) {
		repository.save(converter.getEntity(morador));
	}
	@Override
	public void excluirMorador(int id) {
		repository.delete(id);
	}

}
