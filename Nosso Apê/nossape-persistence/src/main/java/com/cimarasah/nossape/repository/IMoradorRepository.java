/**
 * 
 */
package com.cimarasah.nossape.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import com.cimarasah.nossape.entity.Morador;

/**
 * @author Cimara Sá
 *
 */
@Repository
public interface IMoradorRepository extends JpaRepository<Morador,Integer>{
	
	Morador findById(int id);
	
	@Query("Select m from Morador m where lower(m.nome) like lower('%?1%') asc")
	List<Morador> findByNome(String nome);
}
