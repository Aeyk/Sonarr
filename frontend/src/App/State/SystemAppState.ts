import SystemStatus from 'typings/SystemStatus';
import Update from 'typings/Update';
import AppSectionState, { AppSectionItemState } from './AppSectionState';

export type SystemStatusAppState = AppSectionItemState<SystemStatus>;
export type UpdateAppState = AppSectionState<Update>;
export type UsersAppState = AppSectionState<[]>;

interface SystemAppState {
  updates: UpdateAppState;
  status: SystemStatusAppState;
  users: UsersAppState;
}

export default SystemAppState;
