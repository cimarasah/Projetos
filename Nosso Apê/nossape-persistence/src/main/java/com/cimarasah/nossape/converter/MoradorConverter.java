package com.cimarasah.nossape.converter;

import java.util.ArrayList;
import java.util.List;

import com.cimarasah.nossape.dto.MoradorDTO;
import com.cimarasah.nossape.entity.Morador;

public class MoradorConverter {

	public Morador getEntity(MoradorDTO dto){
		Morador entity = new Morador();
		entity.setId(dto.getId());
		entity.setNome(dto.getNome());
		entity.setDtNascimento(new java.sql.Date(dto.getDtNascimento().getTime()));
		entity.setTelefone(dto.getTelefone());
		entity.setEmail(dto.getEmail());
		entity.setSenha(dto.getSenha());
		entity.setDivideQuarto(dto.isDivideQuarto());
		entity.setAtivo(dto.isAtivo());
		entity.setValorPorQuarto(dto.getValorPorQuarto());
		entity.setDiaLimpeza(dto.getDiaLimpeza());
		return entity;
	}
	
	public MoradorDTO getDTO(Morador entity){
		MoradorDTO dto = new MoradorDTO();
		dto.setId(entity.getId());
		dto.setNome(entity.getNome());
		dto.setDtNascimento(entity.getDtNascimento());
		dto.setTelefone(entity.getTelefone());
		dto.setEmail(entity.getEmail());
		dto.setSenha(entity.getSenha());
		dto.setDivideQuarto(entity.isDivideQuarto());
		dto.setAtivo(entity.isAtivo());
		dto.setValorPorQuarto(entity.getValorPorQuarto());
		dto.setDiaLimpeza(entity.getDiaLimpeza());
		return dto;
	}
	
	public List<Morador> getListEntity(List<MoradorDTO> listDto){
		List<Morador> listEntity = new ArrayList<Morador>();
		for (MoradorDTO dto : listDto) {
			Morador entity = new Morador();
			entity = this.getEntity(dto);
			listEntity.add(entity);
		}
		return listEntity;
		
	}
	public List<MoradorDTO> getListDTO(List<Morador> listEntity){
		List<MoradorDTO> listDTO = new ArrayList<MoradorDTO>();
		for (Morador entity : listEntity) {
			MoradorDTO dto = new MoradorDTO();
			dto = this.getDTO(entity);
			listDTO.add(dto);
		}
		return listDTO;
	}
}
