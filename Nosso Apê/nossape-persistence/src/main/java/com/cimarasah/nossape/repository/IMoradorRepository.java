/**
 * 
 */
package com.cimarasah.nossape.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.cimarasah.nossape.entity.Morador;

/**
 * @author Cimara Sá
 *
 */
@Repository
public interface IMoradorRepository extends JpaRepository<Morador,Integer>{

}
