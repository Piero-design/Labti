# Laboratorio 08: Tecnologías Inmersivas (RA)

Este repositorio contiene el código fuente y los recursos para las aplicaciones de Realidad Aumentada desarrolladas en el Laboratorio 08 del curso de Tecnologías de Información (2026A).

## Ejercicios Desarrollados

### 1. Ejercicio 1: AgroExport Andina S.A.
Aplicación móvil de Realidad Aumentada sin marcadores (Markerless) que permite visualizar maquinaria agrícola (tractor) en 3D directamente sobre una superficie física plana (piso o mesa) utilizando AR Foundation y ARCore.

**Tecnologías:**
- Unity 3D (2022.3 LTS)
- AR Foundation
- Google ARCore XR Plugin

### 2. Ejercicio 2: Muebles Innovar SAC
Aplicación móvil de Realidad Aumentada basada en marcadores (Image Targets) que permite visualizar muebles virtuales sobre un catálogo físico, permitiendo escalado y rotación interactiva mediante gestos táctiles.

**Tecnologías:**
- Unity 3D (2022.3 LTS)
- Vuforia Engine

## Estructura del Repositorio

- `/eje1/`: Código fuente y proyecto de Unity del Ejercicio 1 (AR Foundation).
- `/eje2/`: Código fuente y proyecto de Unity del Ejercicio 2 (Vuforia Engine).
- `/Diagramas/`: Diagramas de arquitectura (Draw.io / Lucidchart).
- `/APKs/`: Archivos instalables `.apk` de ambas aplicaciones.
- `Informe_Tecnico.pdf`: Informe detallado del desarrollo del laboratorio.

## Requisitos Previos

Para ejecutar o editar estos proyectos, necesitas:
- Unity Hub y Unity Editor 2022.3.x LTS.
- Módulo de "Android Build Support" (con OpenJDK, Android SDK y NDK).
- Un dispositivo Android compatible con ARCore (Android 10.0+ API 29+ recomendado).
- Cuenta de desarrollador en Vuforia (para el Ejercicio 2).

## Instalación y Ejecución

1. Clonar el repositorio: `git clone https://github.com/Piero-design/Labti.git`
2. Abrir Unity Hub y añadir los proyectos (`eje1` y `eje2`).
3. En Unity, ir a `File > Build Settings`, asegurar que la plataforma sea Android y hacer clic en `Build and Run` con el dispositivo conectado.

---
**Curso:** Tecnologías de Información  
**Universidad:** Universidad Nacional de San Agustín (UNSA)
