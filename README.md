<h1 align="center">🎮 Proyecto — Sistema de Inventario con ScriptableObject</h1>

<p align="center">
  <b>Proyecto en desarrollo</b><br>
  Implementación de un sistema de <b>recolección y gestión de ítems</b> en Unity, utilizando <b>ScriptableObjects</b> como base de datos dinámica de objetos interactuables.
</p>

---

## 🧩 Descripción General

Este proyecto representa una de las primeras implementaciones prácticas del uso de **ScriptableObjects** para administrar datos de inventario dentro de Unity.  
El objetivo principal es permitir al jugador **recoger ítems**, **almacenarlos** y **utilizarlos** a través de un sistema de inventario modular y escalable.

Actualmente se encuentra **en desarrollo activo**, con parte de la funcionalidad operativa y otra aún en fase de depuración.

---

## ⚙️ Características Principales

- Sistema de **ítems configurables** mediante **ScriptableObjects** (nombre, tipo, icono, cantidad, descripción).  
- **Recolección dinámica** de objetos desde el mundo del juego mediante eventos de colisión o clic.  
- **Inventario visual** (UI) que muestra los ítems recogidos.  
- Base diseñada para permitir futuras expansiones (uso de ítems, crafting o equipamiento).  

---

## 🧠 Arquitectura del Sistema

- **ScriptableObject `ItemData`**  
  Contiene la información persistente del ítem (ID, icono, tipo, descripción).  
  Este enfoque permite reutilizar la misma data en múltiples escenas o prefabs sin duplicación.

- **Componente `ItemPickup`**  
  Detecta la interacción del jugador (clic o colisión) y comunica el evento de recolección.  

- **Componente `InventoryManager`**  
  Gestiona la lista de ítems recogidos, controla su visualización en la UI y el acceso a sus propiedades.  

- **Sistema de eventos**  
  Se utilizan `UnityEvent` o `Event` de C# para comunicar las acciones entre objetos sin referencias directas, mejorando la modularidad del proyecto.  

---

## 🧪 Estado Actual

El sistema de recolección e inventario se encuentra **funcional**, pero durante la implementación se detectó un **error de tipo `NullReferenceException`**, asociado a los **eventos de clic del mouse**.

### 🔍 Descripción del Bug
- El error ocurre de forma intermitente al intentar **interactuar con ciertos ítems**.  
- Se ha identificado que el fallo se origina en la **referencia nula de un evento o componente UI** que aún no está asignado correctamente.  
- La depuración está enfocada en los **eventos del mouse** (clic izquierdo / derecho) que invocan métodos del sistema de inventario.

### 🧰 Próximos pasos
- Revisar el flujo de inicialización de referencias (`Start()` vs `Awake()`).
- Validar la asignación de listeners en los eventos UI.
- Implementar comprobaciones de `null` antes de invocar acciones.  
- Ampliar los `Debug.Log()` para aislar el contexto del fallo.

---

## 🚧 En desarrollo...

- [ ] Implementar sistema de **uso de ítems**.  
- [ ] Depurar error de **NullReferenceException** en eventos de clic.  
- [ ] Optimizar actualización visual del inventario (UI dinámica).  
- [ ] Añadir **efectos visuales o de sonido** al recoger ítems.  

---

## 💡 Aprendizajes y objetivos

Este proyecto sirvió como introducción práctica a:
- La creación y manejo de **ScriptableObjects** como contenedores de datos.  
- El uso de **UnityEvent / Event** para comunicación desacoplada.  
- El diseño modular de un sistema base de **inventario reutilizable**.  
- Identificación y depuración de errores comunes como **referencias nulas**.

El propósito es refinarlo hasta alcanzar un **prototipo estable y extensible**, para reutilizarlo en futuros proyectos personales o educativos.

---

## 🧰 Herramientas utilizadas

- **Unity 2022 LTS**  
- **C# (Programación orientada a objetos)**  
- **UI Toolkit / Canvas (para interfaz de inventario)**  
- **ScriptableObject y UnityEvent**  

---

## 🧑‍💻 Autor

**Milton Denis Castro**  
- 💼 [GitHub](https://github.com/MiltonCastro93)  
- 🎮 [Itch.io](https://milton93.itch.io/)  
- ✉️ [miltondeniscastro.1993@gmail.com](mailto:miltondeniscastro.1993@gmail.com)

---

## 📘 Notas finales

Este repositorio refleja un proceso de **aprendizaje en progreso**, priorizando la comprensión de **estructuras de datos reutilizables** y **eventos** sobre la perfección técnica inmediata.  
El error actual es parte del proceso de mejora continua, y su resolución formará parte de las próximas iteraciones del sistema.

---
