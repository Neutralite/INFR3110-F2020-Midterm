#pragma once

#include "CheckpointTimeLogger.h"

#ifdef __cplusplus
extern "C"
{
#endif

	//Put functions here
	PLUGIN_API void ResetLogger();

	// save most recent checkpoint time
	PLUGIN_API void SaveCheckpointTime(float RTBC);

	// gets total time for race
	PLUGIN_API float GetTotalTime();

	// get checkpoint at time index
	PLUGIN_API float GetCheckpointTime(int index);

	// get number of checkpoints saved
	PLUGIN_API int GetNumCheckpoints();

#ifdef __cplusplus
}
#endif
